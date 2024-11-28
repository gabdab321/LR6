namespace LR6
{
    public interface ICollectionAdapter
    {
        HashSet<T> ToSet<T>(T[] array);
        T[] ToArray<T>(HashSet<T> set);
    }

    public class ArrayToSetAdapter : ICollectionAdapter
    {
        public HashSet<T> ToSet<T>(T[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            return new HashSet<T>(array);
        }

        public T[] ToArray<T>(HashSet<T> set)
        {
            if (set == null) throw new ArgumentNullException(nameof(set));
            return set.ToArray();
        }
    }
    public partial class Form1 : Form
    {
        private readonly ICollectionAdapter _adapter = new ArrayToSetAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnToSet_Click(object sender, EventArgs e)
        {
            var arrayInput = txtArrayInput.Text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var set = _adapter.ToSet(arrayInput);
            txtSetOutput.Text = string.Join(", ", set);
        }

        private void btnToArray_Click(object sender, EventArgs e)
        {
            var setInput = new HashSet<string>(txtSetInput.Text.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries));
            var array = _adapter.ToArray(setInput);
            txtArrayOutput.Text = string.Join(", ", array);
        }
    }
}
