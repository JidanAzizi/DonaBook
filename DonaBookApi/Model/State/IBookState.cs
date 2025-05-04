
namespace DonaBookApi.Model.State
{
    public class IBookState
    {
        private void Handle(IBookState bookState)
        {
            throw new NotImplementedException();
        }

        //Membuat interface IBookState untuk menerapkan State Design Pattern yang mana merupakan implementasi dari state-based
        public interface BookState
        {
            void Handle(Book context);
        }

        public void SetState(IBookState state)
        {
            states = state;
        }

        public class AvailableState : IBookState
        {
            public void Handle(Book context)
            {
                Console.WriteLine("Buku sekarang dipinjam.");
                context.SetState(new BorrowedState());
            }
        }

        public class BorrowedState : IBookState
        {
            public void Handle(Book context)
            {
                Console.WriteLine("Buku sedang dipinjam.");
            }
        }

        private IBookState states;
        public void EnsureStateInit()
        {
            if (states == null)
            {
                states = new AvailableState();// default bahwa buku tersedia.
            }
        }


        public void Request()
        {
            EnsureStateInit();
            states.Handle(this);
        }
    }
}
