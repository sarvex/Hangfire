﻿using System;
using HangFire.Common;
using HangFire.Common.States;
using HangFire.States;
using HangFire.Storage;
using Moq;
using Xunit;

namespace HangFire.Core.Tests.States
{
    public class SucceededStateHandlerFacts
    {
        private const string JobId = "1";

        private readonly StateApplyingContext _context;
        private readonly Mock<IWriteOnlyTransaction> _transactionMock
            = new Mock<IWriteOnlyTransaction>();

        public SucceededStateHandlerFacts()
        {
            var methodInfo = typeof(SucceededStateHandlerFacts)
                .GetMethod("TestMethod");
            var jobMethod = new JobMethod(typeof(SucceededStateHandlerFacts), methodInfo);
            var stateContext = new StateContext(JobId, jobMethod);
            var stateMock = new Mock<JobState>();

            _context = new StateApplyingContext(stateContext, _transactionMock.Object, stateMock.Object);
        }

        [Fact]
        public void ShouldWorkOnlyWithSucceededState()
        {
            var handler = new SucceededState.Handler();
            Assert.Equal(SucceededState.Name, handler.StateName);
        }

        [Fact]
        public void Apply_ShouldSet_JobExpirationDate()
        {
            var handler = new SucceededState.Handler();
            handler.Apply(_context);

            _transactionMock.Verify(x => x.ExpireJob(JobId, It.IsAny<TimeSpan>()));
        }

        [Fact]
        public void Apply_ShouldIncrease_SucceededCounter()
        {
            var handler = new SucceededState.Handler();
            handler.Apply(_context);

            _transactionMock.Verify(x => x.IncrementCounter("stats:succeeded"), Times.Once);
        }

        [Fact]
        public void Unapply_ShouldRemoveJobExpirationDate()
        {
            var handler = new SucceededState.Handler();
            handler.Unapply(_context);

            _transactionMock.Verify(x => x.PersistJob(JobId));
        }

        [Fact]
        public void Unapply_ShouldDecrementStatistics()
        {
            var handler = new SucceededState.Handler();
            handler.Unapply(_context);

            _transactionMock.Verify(x => x.DecrementCounter("stats:succeeded"), Times.Once);
        }

        public void TestMethod()
        {
        }
    }
}