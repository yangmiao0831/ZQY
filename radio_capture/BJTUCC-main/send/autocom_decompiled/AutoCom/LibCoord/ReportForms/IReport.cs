using System.Collections.Generic;

namespace LibCoord.ReportForms;

public interface IReport
{
	string ResultFile { get; }

	UpdateProgressHandle UpdateProgressHandle { get; set; }

	bool WriteReport(IList<RPTDataModel> datas, ReportDefine define);
}
