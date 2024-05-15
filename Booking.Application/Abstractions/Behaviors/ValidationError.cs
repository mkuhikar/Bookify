using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Application.Abstractions.Behaviors;
public sealed record ValidationError(string PropetyName, string ErrorMessage);

