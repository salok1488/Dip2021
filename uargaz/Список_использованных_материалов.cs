//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uargaz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Список_использованных_материалов
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Список_использованных_материалов()
        {
            this.Аварийная_работа = new HashSet<Аварийная_работа>();
        }
    
        public int Код { get; set; }
        public string Название { get; set; }
        public Nullable<int> Количество { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Аварийная_работа> Аварийная_работа { get; set; }
    }
}
