// <auto-generated>This is auto-generated code by DIS. Do not modify.</auto-generated>
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skyline.DataMiner.Scripting
{
public static class Parameter
{
	/// <summary>PID: 100 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int rssfeedurl_100 = 100;
	/// <summary>PID: 100 | Type: read</summary>
	public const int rssfeedurl = 100;
	public class Write
	{
		/// <summary>PID: 101 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int rssfeedurl_101 = 101;
		/// <summary>PID: 101 | Type: write</summary>
		public const int rssfeedurl = 101;
	}
	public class Rssfeedoverview
	{
		/// <summary>PID: 1000</summary>
		public const int tablePid = 1000;
		/// <summary>IDX: 0</summary>
		public const int indexColumn = 0;
		/// <summary>PID: 1001</summary>
		public const int indexColumnPid = 1001;
		public class Pid
		{
			/// <summary>PID: 1001 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rssfeedoverviewinstance_1001 = 1001;
			/// <summary>PID: 1001 | Type: read</summary>
			public const int rssfeedoverviewinstance = 1001;
			/// <summary>PID: 1002 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rssfeedoverviewtitle_1002 = 1002;
			/// <summary>PID: 1002 | Type: read</summary>
			public const int rssfeedoverviewtitle = 1002;
			/// <summary>PID: 1003 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rssfeedoverviewsummary_1003 = 1003;
			/// <summary>PID: 1003 | Type: read</summary>
			public const int rssfeedoverviewsummary = 1003;
			public class Write
			{
			}
		}
		public class Idx
		{
			/// <summary>IDX: 0 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rssfeedoverviewinstance_1001 = 0;
			/// <summary>IDX: 0 | Type: read</summary>
			public const int rssfeedoverviewinstance = 0;
			/// <summary>IDX: 1 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rssfeedoverviewtitle_1002 = 1;
			/// <summary>IDX: 1 | Type: read</summary>
			public const int rssfeedoverviewtitle = 1;
			/// <summary>IDX: 2 | Type: read</summary>
			[EditorBrowsable(EditorBrowsableState.Never)]
			public const int rssfeedoverviewsummary_1003 = 2;
			/// <summary>IDX: 2 | Type: read</summary>
			public const int rssfeedoverviewsummary = 2;
		}
	}
}
public class WriteParameters
{
	/// <summary>PID: 101  | Type: write</summary>
	public System.Object Rssfeedurl {get { return Protocol.GetParameter(101); }set { Protocol.SetParameter(101, value); }}
	public SLProtocolExt Protocol;
	public WriteParameters(SLProtocolExt protocol)
	{
		Protocol = protocol;
	}
}
public interface SLProtocolExt : SLProtocol
{
	/// <summary>PID: 1000</summary>
	RssfeedoverviewQActionTable rssfeedoverview { get; set; }
	object Afterstartup_dummy { get; set; }
	object Readrss_dummy { get; set; }
	object Rssfeedurl_100 { get; set; }
	object Rssfeedurl { get; set; }
	object Rssfeedurl_101 { get; set; }
	object Rssfeedoverviewinstance_1001 { get; set; }
	object Rssfeedoverviewinstance { get; set; }
	object Rssfeedoverviewtitle_1002 { get; set; }
	object Rssfeedoverviewtitle { get; set; }
	object Rssfeedoverviewsummary_1003 { get; set; }
	object Rssfeedoverviewsummary { get; set; }
	WriteParameters Write { get; set; }
}
public class ConcreteSLProtocolExt : ConcreteSLProtocol, SLProtocolExt
{
	/// <summary>PID: 1000</summary>
	public RssfeedoverviewQActionTable rssfeedoverview { get; set; }
	/// <summary>PID: 2  | Type: dummy</summary>
	public System.Object Afterstartup_dummy {get { return GetParameter(2); }set { SetParameter(2, value); }}
	/// <summary>PID: 10  | Type: dummy</summary>
	public System.Object Readrss_dummy {get { return GetParameter(10); }set { SetParameter(10, value); }}
	/// <summary>PID: 100  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Rssfeedurl_100 {get { return GetParameter(100); }set { SetParameter(100, value); }}
	/// <summary>PID: 100  | Type: read</summary>
	public System.Object Rssfeedurl {get { return GetParameter(100); }set { SetParameter(100, value); }}
	/// <summary>PID: 101  | Type: write</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Rssfeedurl_101 {get { return GetParameter(101); }set { SetParameter(101, value); }}
	/// <summary>PID: 1001  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Rssfeedoverviewinstance_1001 {get { return GetParameter(1001); }set { SetParameter(1001, value); }}
	/// <summary>PID: 1001  | Type: read</summary>
	public System.Object Rssfeedoverviewinstance {get { return GetParameter(1001); }set { SetParameter(1001, value); }}
	/// <summary>PID: 1002  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Rssfeedoverviewtitle_1002 {get { return GetParameter(1002); }set { SetParameter(1002, value); }}
	/// <summary>PID: 1002  | Type: read</summary>
	public System.Object Rssfeedoverviewtitle {get { return GetParameter(1002); }set { SetParameter(1002, value); }}
	/// <summary>PID: 1003  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Rssfeedoverviewsummary_1003 {get { return GetParameter(1003); }set { SetParameter(1003, value); }}
	/// <summary>PID: 1003  | Type: read</summary>
	public System.Object Rssfeedoverviewsummary {get { return GetParameter(1003); }set { SetParameter(1003, value); }}
	public WriteParameters Write { get; set; }
	public ConcreteSLProtocolExt()
	{
		rssfeedoverview = new RssfeedoverviewQActionTable(this, 1000, "rssfeedoverview");
		Write = new WriteParameters(this);
	}
}
/// <summary>IDX: 0</summary>
public class RssfeedoverviewQActionTable : QActionTable, IEnumerable<RssfeedoverviewQActionRow>
{
	public RssfeedoverviewQActionTable(SLProtocol protocol, int tableId, string tableName) : base(protocol, tableId, tableName) { }
	IEnumerator IEnumerable.GetEnumerator() { return (IEnumerator) GetEnumerator(); }
	public IEnumerator<RssfeedoverviewQActionRow> GetEnumerator() { return new QActionTableEnumerator<RssfeedoverviewQActionRow>(this); }
}
/// <summary>IDX: 0</summary>
public class RssfeedoverviewQActionRow : QActionTableRow
{
	/// <summary>PID: 1001 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Rssfeedoverviewinstance_1001 { get { if (base.Columns.ContainsKey(0)) { return base.Columns[0]; } else { return null; } } set { if (base.Columns.ContainsKey(0)) { base.Columns[0] = value; } else { base.Columns.Add(0, value); } } }
	/// <summary>PID: 1001 | Type: read</summary>
	public System.Object Rssfeedoverviewinstance { get { if (base.Columns.ContainsKey(0)) { return base.Columns[0]; } else { return null; } } set { if (base.Columns.ContainsKey(0)) { base.Columns[0] = value; } else { base.Columns.Add(0, value); } } }
	/// <summary>PID: 1002 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Rssfeedoverviewtitle_1002 { get { if (base.Columns.ContainsKey(1)) { return base.Columns[1]; } else { return null; } } set { if (base.Columns.ContainsKey(1)) { base.Columns[1] = value; } else { base.Columns.Add(1, value); } } }
	/// <summary>PID: 1002 | Type: read</summary>
	public System.Object Rssfeedoverviewtitle { get { if (base.Columns.ContainsKey(1)) { return base.Columns[1]; } else { return null; } } set { if (base.Columns.ContainsKey(1)) { base.Columns[1] = value; } else { base.Columns.Add(1, value); } } }
	/// <summary>PID: 1003 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Rssfeedoverviewsummary_1003 { get { if (base.Columns.ContainsKey(2)) { return base.Columns[2]; } else { return null; } } set { if (base.Columns.ContainsKey(2)) { base.Columns[2] = value; } else { base.Columns.Add(2, value); } } }
	/// <summary>PID: 1003 | Type: read</summary>
	public System.Object Rssfeedoverviewsummary { get { if (base.Columns.ContainsKey(2)) { return base.Columns[2]; } else { return null; } } set { if (base.Columns.ContainsKey(2)) { base.Columns[2] = value; } else { base.Columns.Add(2, value); } } }
	public RssfeedoverviewQActionRow() : base(0, 3) { }
	public RssfeedoverviewQActionRow(System.Object[] oRow) : base(0, 3, oRow) { }
	public static implicit operator RssfeedoverviewQActionRow(System.Object[] source) { return new RssfeedoverviewQActionRow(source); }
	public static implicit operator System.Object[](RssfeedoverviewQActionRow source) { return source.ToObjectArray(); }
}
}
