﻿using Bookify.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Users.Events
{
	public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
}
