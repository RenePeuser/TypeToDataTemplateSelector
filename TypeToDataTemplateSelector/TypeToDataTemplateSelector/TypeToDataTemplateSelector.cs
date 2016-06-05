using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TypeToDataTemplateSelector
{
    public class TypeDataTemplateSelector : DataTemplateSelector
    {
        public List<TypeToDataTemplate> TypeToDataTemplates { get; set; }

        public TypeDataTemplateSelector()
        {
            TypeToDataTemplates = new List<TypeToDataTemplate>();
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var type = item.GetType();
            var typeToDataTemplate = TypeToDataTemplates.FirstOrDefault(t => t.Type == type);
            return typeToDataTemplate?.DataTemplate;
        }
    }
}
