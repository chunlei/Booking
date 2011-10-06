﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit.Extensions;
using Xunit;
using Ploeh.Samples.Booking.DomainModel;
using Ploeh.AutoFixture.Xunit;

namespace Ploeh.Samples.Booking.DomainModel.UnitTest
{
    public class ReservationAcceptedEventTests
    {
        [Theory, AutoDomainData]
        public void SutIsMessage(ReservationAcceptedEvent sut)
        {
            Assert.IsAssignableFrom<IMessage>(sut);
        }

        [Theory, AutoDomainData]
        public void IdIsCorrect([Frozen]Guid id, ReservationAcceptedEvent sut)
        {
            Assert.Equal<Guid>(id, sut.Id);
        }
    }
}
