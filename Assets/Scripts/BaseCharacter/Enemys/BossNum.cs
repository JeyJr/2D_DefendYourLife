using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossNum : MonoBehaviour
{
    
    public int bossNum;
    public void UnlockNextLevel() {
        LevelUnlockData levelUnlock = GameData.LoadLevelData();
        Debug.Log($"Level unlock: {levelUnlock.levelUnlock}");
        Debug.Log($"Boss num: {bossNum}");

        if(levelUnlock.levelUnlock <= bossNum)
        {
            GameData.SaveLevelData(bossNum + 1);

            //Somente para verificar se salvou o novo numero
            levelUnlock = GameData.LoadLevelData();
            Debug.Log($"Novo n�vel desbloqueado: {levelUnlock.levelUnlock}");
        }
        else
        {
            Debug.Log($"Boss ja foi derrotado!");
            Debug.Log($"N�veis desbloqueados: {levelUnlock.levelUnlock}");
        }
    }
}
