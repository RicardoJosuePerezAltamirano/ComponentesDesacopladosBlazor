namespace BlazorApp1.Client
{
    public class ComponentEvents:MessaginCenter
    {
        public event StateNotify ClickEvent;

        public void ButtonClicked(object sender,StateArguments e)
        {
            if(ClickEvent != null)
            {
                ClickEvent(sender, e);
            }
        }
    }
}
