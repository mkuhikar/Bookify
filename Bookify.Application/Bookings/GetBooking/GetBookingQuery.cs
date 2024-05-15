using Bookify.Application.Abstractions.Data;
using Bookify.Application.Abstractions.Messaging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Application.Bookings.GetBooking
{
	public sealed  record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>
	{

	}

}
