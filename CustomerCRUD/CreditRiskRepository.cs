using CustomerCRUD.Data;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCRUD
{
    public class CreditRiskRepository : IRepository<CreditRisks>
    {
       private AutoLotContext _dbCreditRisk = new AutoLotContext();

        public IEnumerable<CreditRisks> GetAll()
        {
            try
            {
                List<CreditRisks> credito = _dbCreditRisk.creditRisks.ToList();
                return credito;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener de la base de datos: {ex.Message}");
            }
        }

        public CreditRisks GetValue(int id)
        {
            try
            {
                CreditRisks creditRisk = _dbCreditRisk.creditRisks.Find(id);
                return creditRisk;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener de la base de datos: {ex.Message}");
            }
        }

        public void Insert(CreditRisks creditRisk)
        {
            try
            {
                CreditRisks creditToAdd = new CreditRisks
                {
                    CustomerId = creditRisk.CustomerId,
                    FirstName = creditRisk.FirstName,
                    LastName = creditRisk.LastName,
                };
                _dbCreditRisk.Add(creditToAdd);
                _dbCreditRisk.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al insertar en la base de datos: {ex.Message}");
            }
        }

        public void Update(CreditRisks credit)
        {
            try
            {
                CreditRisks creditToUpdate = _dbCreditRisk.creditRisks.Find(credit.Id);
                creditToUpdate.CustomerId = credit.CustomerId;
                creditToUpdate.FirstName = credit.FirstName;
                creditToUpdate.LastName = credit.LastName;
                _dbCreditRisk.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar de la base de datos: {ex.Message}");
            }
        }
        public void Delete(int id)
        {
            try
            {
                CreditRisks credit = GetValue(id);
                _dbCreditRisk.creditRisks.Remove(credit);
                _dbCreditRisk.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar de la base de datos: {ex.Message}");
            }
        }
    }
}
