using BotFactory.Common.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotFactory.Factories
{
    public class UnitFactory : IUnitFactory
    {
        private int QueueCapacity { get; set; }
        private int StorageCapacity { get; set; }
        private int QueueFreeSlots { get; set; }
        private int StorageFreeSlots { get; set; }
        public Queue<FactoryQueueElement> queue;
        public List<ITestingUnit> Storage { get; set; }
        public event FactoryProgressDelegate FactoryProgress;

        public UnitFactory(int queueCapacity, int storageCapacity)
        {
            QueueCapacity = queueCapacity;
            StorageCapacity = storageCapacity;
        }
        public bool AddWorkableUnitToQueue(Type model, string name, Coordinates parkingPos, Coordinates workingPos)
        {
            //  prenant en paramètre le modèle, le nom du robot, sa position de stationnement, ainsi que sa position de travail
            //  La méthode doit répondre aux critères suivants:
            //  -L’usine ne peut construire qu’un robot à la fois.
            //  -L’usine ne peut enregistrer plus de commandes si sa queue est pleine
            //  -L’usine ne peut construire plus de robots si son entrepôt est plein
            //  -On peut appeler l’ajout de commande n’importe quand
            //  -La méthode doit retourner false si la commande n’est pas enregistrée
            //  -La construction doit être active tant que la queue n’est pas vide ou l’entrepôt plein
            //  -La construction d’un robot doit être simulée et prendre le temps indiqué par la propriété BuildTime du robot
            return true;
        }
    }
}
