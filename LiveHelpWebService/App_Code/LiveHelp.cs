using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for LiveHelp
/// </summary>
public class LiveHelp
{
	public LiveHelp()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public Int32 MemberID
    {
        get;
        set;
    }
    public string ParentID
    {
        get;
        set;
    }
    public Int32 RecordTypeID
    {
        get;
        set;
    }
    public Int32 Status
    {
        get;
        set;
    }
    public Int32 Origin
    {
        get;
        set;
    }
    public string Subject
    {
        get;
        set;
    }
    public string Description
    {
        get;
        set;
    }
    public bool HasCommentsUnreadByOwner
    {
        get;
        set;
    }
    public string CreatedBy
    {
        get;
        set;
    }
    public DateTime CreatedDate
    {
        get;
        set;
    }
    public string Ticket_ID
    {
        get;
        set;
    }
    public bool Complain
    {
        get;
        set;
    }
    public int Type
    {
        get;
        set;
    }
    public int Sub_Type
    {
        get;
        set;
    }
    public Int32 Referral_Detail
    {
        get;
        set;
    }
    public Int32 HowDoTheyFeelAboutUs
    {
        get;
        set;
    }
    public string Summary_Of_Chat
    {
        get;
        set;
    }
    public string LastModifiedBy
    {
        get;
        set;
    }

}