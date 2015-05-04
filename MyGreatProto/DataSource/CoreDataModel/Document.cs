using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGreatProto.CoreDataModel
{
	public class BaseDocument
	{
		public int BaseDocumentId { get; set; }
		public string Series { get; set; }
		public int Number { get; set; }

		public DateTime IssueTime { get; set; }
	}

	public class Passport: BaseDocument
	{

	}

	public class License: BaseDocument
	{

	}
}
