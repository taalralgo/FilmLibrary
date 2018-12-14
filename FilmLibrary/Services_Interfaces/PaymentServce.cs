using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PaymentServce" à la fois dans le code et le fichier de configuration.
    public class PaymentServce : IPaymentServce
    {
        DBContext db = new DBContext();
        public Payment Add(Payment payment)
        {
            try
            {
                db.Payments.Add(payment);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return payment;
        }

        public Payment Find(int id)
        {
            try
            {
                return db.Payments.Where(p => p.PaymentId.Equals(id)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Payment> FindAll()
        {
            try
            {
                return db.Payments.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int id, int montant, Customer customer)
        {
            try
            {
                Payment payment = new Payment();
                payment.PaymentAmount = montant;
                payment.CustomerId = customer;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
