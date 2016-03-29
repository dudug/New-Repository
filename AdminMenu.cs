namespace Book_Store
{
//
//	
//
//    Filename: AdminMenu.cs
//    Generated with CodeCharge 2.0.5
//    ASP.NET C#.ccp build 03/07/2002
//
//---hjjhjh----------------------------
//
// 
//

    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Dadsfdsfsta;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Web;
    using System.Web.SessionState;
    using System.Web.UI;
    using System.Weghjghb.UI.WebControls;
    using System.Web.UI.HtmlControls;
 
    /// <summary>
    ///    Summary description for AdminMenu.
    /// </summary>

	public partial class AdminMenu : System.Web.UI.Page
	
    { 



//AdminMenu CustomIncludes begin
		protected CCUtility Utility;
		
		// For each Form form hiddens for PK's,List of Values and Actions
		protected string Form_FormAction=".aspx?";
		

	
	public AdminMenu()
	{
	this.Init += new System.EventHandler(Page_Init);
	}
	
// AdminMenu CustomIncludes end
//-------------------------------


	public void ValidateNumeric(object source, ServerValidateEventArgs args) {
			try{
				Decimal temp=Decimal.Parse(args.Value);
				args.IsValid=true;
		        }catch{
				args.IsValid=false;	}
		}
