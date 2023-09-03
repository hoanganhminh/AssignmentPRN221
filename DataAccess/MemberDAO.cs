using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        public static Member Login(string email, string password)
        {
            Member member = null;
            try
            {
                using (var context = new SaleManagementDBContext())
                {
                    member = context.Members.SingleOrDefault(m => m.Email.Equals(email) && m.Password.Equals(password));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public static List<Member> GetMembers()
        {
            List<Member> members;
            try
            {
                using (var context = new SaleManagementDBContext())
                {
                    members = context.Members.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public static Member GetMemberById(int id)
        {
            Member member = null;
            try
            {
                using (var context = new SaleManagementDBContext())
                {
                    member = context.Members.SingleOrDefault(m => m.MemberId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public static void UpdateMember(Member member)
        {
            try
            {
                Member m = GetMemberById(member.MemberId);
                if (m != null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Entry<Member>(member).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The member does not exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void RemoveMember(Member member)
        {
            try
            {
                Member m = GetMemberById(member.MemberId);
                if (m != null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Remove(member);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The member does not exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void InsertMember(Member member)
        {
            try
            {
                Member m = GetMemberById(member.MemberId);
                if (m == null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Add(member);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The member already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
