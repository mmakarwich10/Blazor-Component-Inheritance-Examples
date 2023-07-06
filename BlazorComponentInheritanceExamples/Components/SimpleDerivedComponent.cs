namespace BlazorComponentInheritanceExamples.Components
{
    public class SimpleDerivedComponent : SimpleBaseComponent
    { // Even though this is a normal class, because it's inheriting from a component, it will be treated as a component.
        // Any class inheriting (however distantly) from ComponentBase will exhibit the same behavior.
        protected override void OnInitialized()
        {
            Header = "Header from derived component";
            base.OnInitialized();
        }
    }
}
