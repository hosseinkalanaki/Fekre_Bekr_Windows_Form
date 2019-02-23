namespace FekreBekrWindowsForm
{
    public class buttonchanges
    {
        public buttonchanges(int YLocation)
        {
            ylocation = YLocation;
        }

        private int ylocation;

        public int getlocation()
        {
            ylocation -= 49;

            return ylocation;
        }

    }
}
