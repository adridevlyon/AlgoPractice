namespace Sorting
{
    public class ISortFactory
    {
        public static ISort GetSort(Sort sort = Sort.QuickSort)
        {
            switch (sort)
            {
                case Sort.QuickSort:
                    return new QuickSort();
                default:
                    return new QuickSort();
            }
        }
    }
}
