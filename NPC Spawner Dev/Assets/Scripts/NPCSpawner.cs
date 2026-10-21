using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_Factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;
    private INPC m_Warrior;
    private INPC m_Wizard;
    private INPC m_Ron;

    public void SpawnVillagers()
    {
        /**
        We don't want to specify the class to instiate for each type
        of villager.
        Instead, we ask the facory to "manufacture" it for us.
        **/

        m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
        m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
        m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
        m_Warrior = m_Factory.GetNPC(NPCType.Warrior);
        m_Wizard = m_Factory.GetNPC(NPCType.Wizard);
        m_Ron = m_Factory.GetNPC(NPCType.Ron);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
        m_Warrior.Speak();
        m_Wizard.Speak();
        m_Ron.Speak();
    }
}
