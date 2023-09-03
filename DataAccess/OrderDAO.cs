using DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        public static List<Order> GetOrders()
        {
            List<Order> orders;
            try
            {
                using (var context = new SaleManagementDBContext())
                {
                    orders = context.Orders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public static Order GetOrderById(int id)
        {
            Order order = null;
            try
            {
                using (var context = new SaleManagementDBContext())
                {
                    order = context.Orders.SingleOrDefault(o => o.OrderId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public static void UpdateOrder(Order order)
        {
            try
            {
                Order o = GetOrderById(order.OrderId);
                if (o != null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Entry<Order>(order).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The order does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void RemoveOrder(Order order)
        {
            try
            {
                Order o = GetOrderById(order.OrderId);
                if (o != null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Remove(order);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The order does not exist.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void InsertOrder(Order order)
        {
            try
            {
                Order o = GetOrderById(order.OrderId);
                if (o == null)
                {
                    using (var context = new SaleManagementDBContext())
                    {
                        context.Add(order);
                        context.SaveChanges();
                    }
                }
                else
                {
                    throw new Exception("The order already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
