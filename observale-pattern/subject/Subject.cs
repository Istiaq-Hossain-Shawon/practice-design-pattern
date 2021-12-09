using observale_pattern.observale;

namespace observale_pattern.subject
{
    public interface Subject
    {
         public void Register(Observale observale); 
         public void UnRegister(Observale observale); 
         public void NotifyObservale(); 
    }
}
