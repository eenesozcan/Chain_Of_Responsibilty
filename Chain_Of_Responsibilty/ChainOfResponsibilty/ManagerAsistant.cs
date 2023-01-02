using Chain_Of_Responsibilty.DAL;

namespace Chain_Of_Responsibilty.ChainOfResponsibilty
{
    public class ManagerAsistant:Employee
    {
        Context context = new Context();
        public override void ProcessRequest(Withdraw req)
        {
            if (req.Amount <= 70000)
            {
                ProcessDetail p = new ProcessDetail();
                p.EmployeeName = "Ersin Kayalı";
                p.EmployeeTitle = "Şube Müdür Yardımcısı";
                p.Description = "Müşterinin talep ettiği tutar Şube Müdür Yardımcısı tarafından ödendi";
                p.Amount = req.Amount;
                context.ProcessDetails.Add(p);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                ProcessDetail p = new ProcessDetail();
                p.EmployeeName = "Ersin Kayalı";
                p.EmployeeTitle = "Şube Müdür Yardımcısı";
                p.Description = "Müşterinin talep ettiği tutar bulunduğum yetki değerini aştığı için müşteriyi Şube Müdürüne yönlendirmiş bulunmaktayım";
                p.Amount = req.Amount;
                context.ProcessDetails.Add(p);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
