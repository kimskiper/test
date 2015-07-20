using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
	public DAL()
	{
		
	}

    public void InsertLiveHelpData_to_TCase1(LiveHelp lhInput)
    {
        try
        {
            string tempConn = ConfigurationManager.AppSettings["conCRMMS1"];
            string connCRMstr = tempConn.Replace("[xxx]", "y@d$t&a%09$pa%ad");

            using (SqlConnection connection = new SqlConnection(connCRMstr))
                {
                    using (SqlCommand cmd = new SqlCommand("[dbo].[spTCase1Insert]", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@memberid", SqlDbType.BigInt).Value = lhInput.MemberID;
                        cmd.Parameters.Add("@ParentID", SqlDbType.VarChar, 15).Value = lhInput.ParentID;
                        cmd.Parameters.Add("@RecordTypeID", SqlDbType.BigInt).Value = lhInput.RecordTypeID;
                        cmd.Parameters.Add("@Status", SqlDbType.BigInt).Value = lhInput.Status;
                        cmd.Parameters.Add("@Origin", SqlDbType.BigInt).Value = lhInput.Origin;
                        cmd.Parameters.Add("@Subject", SqlDbType.NVarChar, 300).Value = lhInput.Subject;
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = lhInput.Description;
                        cmd.Parameters.Add("@HasCommentsUnreadByOwner", SqlDbType.Bit).Value = lhInput.HasCommentsUnreadByOwner;
                        cmd.Parameters.Add("@createdBy", SqlDbType.VarChar, 50).Value = lhInput.CreatedBy;
                        cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = lhInput.CreatedDate;
                        cmd.Parameters.Add("@Ticket_ID", SqlDbType.VarChar, 50).Value = lhInput.Ticket_ID;
                        cmd.Parameters.Add("@Complain", SqlDbType.Bit).Value = lhInput.Complain;
                        cmd.Parameters.Add("@Type", SqlDbType.BigInt).Value = lhInput.Type;
                        cmd.Parameters.Add("@Sub_Type", SqlDbType.VarChar, 100).Value = lhInput.Sub_Type;
                        cmd.Parameters.Add("@Referral_Detail", SqlDbType.BigInt).Value = lhInput.Referral_Detail;
                        cmd.Parameters.Add("@HowDoTheyFeelAboutUs", SqlDbType.BigInt).Value = lhInput.HowDoTheyFeelAboutUs;
                        cmd.Parameters.Add("@Summary_Of_Chat", SqlDbType.NVarChar).Value = lhInput.Summary_Of_Chat;
                        cmd.Parameters.Add("@LastModifiedBy", SqlDbType.VarChar, 50).Value = lhInput.LastModifiedBy;

                        connection.Open();
                        object val = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                    }
                }

        }
        catch (Exception Ex)
        {
            throw Ex;
        }
    }

}