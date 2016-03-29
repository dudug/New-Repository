namespace Book_Store
{
	
//
//    Filename: AdminBooks.cs
//    Generated with CodeCharge 2.0.5
//    ASP.NET C#.ccp build 03/07/2002
//
//--------------------------------
//

    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Web;
    using System.Web.SessionState;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.HtmlControls;

    /// <summary>
    ///    Summary description for AdminBooks.
    /// </summary>
	///

	public partial class AdminBooks : System.Web.UI.Page
	
    {


        //ToDO abc
        //ToDO abc

//AdminBooks CustomIncludes begin
        protected CCUtility Utility;
		
		//Search form Search variables and controls declarations
		
		//Grid form Items variables and controls declarations
		protected string Items_sSQL;
		protected string Items_sCountSQL;
		protected int Items_CountPage;
//protected System.Web.UI.WebControls.LinkButton Items_insert;
		protected int i_Items_curpage=1;	
	
		// For each Search form hiddens for PK's,List of Values and Actions
		protected string Search_FormAction="AdminBooks.aspx?";
		protected String[] Search_is_recommended_lov = ";All;0;No;1;Yes".Split(new Char[] {';'});
		// For each Items form hiddens for PK's,List of Values and Actions
		protected string Items_FormAction="BookMaint.aspx?";
		protected String[] Items_is_recommended_lov = "0;No;1;Yes".Split(new Char[] {';'});

	
	public AdminBooks()
	{
        int i = 10;
        int ii = 1010;
	this.Init += new System.EventHandler(Page_Init);
	}
