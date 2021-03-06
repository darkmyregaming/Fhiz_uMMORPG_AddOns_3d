// =======================================================================================
// Created and maintained by iMMO
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............: https://discord.gg/YkMbDHs
// * Public downloads website...........: https://www.indie-mmo.net
// * Pledge on Patreon for VIP AddOns...: https://www.patreon.com/IndieMMO
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using UnityEngine;

// ===================================================================================
// NPC RESTRICTIONS
// ===================================================================================
public partial class Npc
{
    [Header("[NPC RESTRICTIONS]")]
    public UCE_Requirements npcRestrictions;

    protected UCE_UI_NpcAccessRequirement instance;

    // -----------------------------------------------------------------------------------
    // UCE_ValidateNpcRestrictions
    // -----------------------------------------------------------------------------------
    [DevExtMethods("Awake")]
    private void Awake_UCE_NpcRestrictions()
    {
        if (instance == null)
            instance = FindObjectOfType<UCE_UI_NpcAccessRequirement>();
    }

    // -----------------------------------------------------------------------------------
    // UCE_ValidateNpcRestrictions
    // -----------------------------------------------------------------------------------
    public bool UCE_ValidateNpcRestrictions(Player player)
    {
        bool bValid = npcRestrictions.checkRequirements(player);
        if (!bValid)
            instance.Show(gameObject);
        return bValid;
    }

    // -----------------------------------------------------------------------------------
    // UCE_ValidateNpcRestrictions
    // -----------------------------------------------------------------------------------
    public void ConfirmAccess()
    {
        UINpcDialogue.singleton.Show();
    }

    // -----------------------------------------------------------------------------------
}
