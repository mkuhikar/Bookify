using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Apartments
{
	//The "Repository" suffix clearly communicates the purpose of the interface or class.
	//It indicates responsibility
	///for retrieving, storing, and managing domain objects within the application.
	public interface IApartmentRepository
	{
		Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
	}
}
