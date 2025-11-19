using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public Item RewardItem { get; set; }

        public Quest(int id, string name, string description, int rewardExperience, int rewardGold, Item rewardItem = null)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperience;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
        }
    }
}
