using System;

namespace BearAdapter
{
    /// <summary>
    /// The adapter class always implements the interface it's trying to
    /// adapt to.
    /// </summary>
    public class BearAdapter : IDog
    {
        /// <summary>
        /// An adapter always keeps a reference to the object it adapts, in
        /// this case, a concrete instance of IBear.
        /// </summary>
        private IBear bear;

        /// <summary>
        /// Bears don't bark, they roar, so we adapt the method accordingly
        /// </summary>
        public void Bark()
        {
            bear.Roar();
        }

        /// <summary>
        /// Bears don't fetch objects like dogs. They will go towards the
        /// target and try eating it.
        /// </summary>
        /// <param name="objectToFetch">
        /// Object the bear will "fetch".
        /// </param>
        public void Fetch(object objectToFetch)
        {
            bear.LookAt(objectToFetch);
            bear.GoTowards(objectToFetch);
            bear.TryEat(objectToFetch);
        }

        /// <summary>
        /// Create a new instance of a bear adapter.
        /// </summary>
        /// <param name="wolf">The bear to be adapted as a dog.</param>
        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }
    }
}
