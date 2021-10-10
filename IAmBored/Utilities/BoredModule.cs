#region Namespaces

using Newtonsoft.Json;

#endregion

namespace IAmBored.Utilities
{
    /// <summary>
    ///     The <see cref="BoredModule" /> class.
    /// </summary>
    public class BoredModule
    {
        /// <summary>
        ///     Gets or sets the activity.
        /// </summary>
        /// <value>
        ///     The activity.
        /// </value>
        public string Activity { get; private set; }

        /// <summary>
        ///     Gets or sets the accessibility.
        /// </summary>
        /// <value>
        ///     The accessibility.
        /// </value>
        public string Accessibility { get; private set; }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        public string Type { get; private set; }

        /// <summary>
        ///     Gets or sets the participants.
        /// </summary>
        /// <value>
        ///     The participants.
        /// </value>
        public string Participants { get; private set; }

        /// <summary>
        ///     Gets or sets the price.
        /// </summary>
        /// <value>
        ///     The price.
        /// </value>
        public string Price { get; private set; }

        /// <summary>
        ///     Gets or sets the link.
        /// </summary>
        /// <value>
        ///     The link.
        /// </value>
        public string Link { get; private set; }

        /// <summary>
        ///     Gets or sets the key.
        /// </summary>
        /// <value>
        ///     The key.
        /// </value>
        public string Key { get; private set; }

        /// <summary>
        ///     Loads the module.
        /// </summary>
        /// <param name="json">The json.</param>
        public void LoadModule(string json)
        {
            if (!string.IsNullOrEmpty(json))
            {
                dynamic module = JsonConvert.DeserializeObject(json);

                if (module != null)
                {
                    Activity = module.activity;
                    Accessibility = module.accessibility;
                    Type = module.type;
                    Participants = module.participants;
                    Price = module.price;
                    Link = module.link;
                    Key = module.key;
                }
            }
        }
    }
}