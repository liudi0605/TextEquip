//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

public delegate void DictVoid_LoadFinishedCallBack();
public delegate void DictString_LoadFinishedCallBack(string filePath);

public partial class DictDataManager
{
    private static DictDataManager m_instance;
    private string m_dataPath;
    private int m_initCount = 0;
    private bool m_isInit = false;

    //
    private DictVoid_LoadFinishedCallBack m_loadFinishedCallBack;

    public static DictDataManager Instance
    {
        get
        {
            if(m_instance == null)
            {
                m_instance = new DictDataManager();
            }

            return m_instance;
        }
    }

    public static void Release()
    {
        m_instance = null;
    }

    public void Init(string path,DictVoid_LoadFinishedCallBack callBack)
    {
      m_loadFinishedCallBack = callBack;

      //
      if(m_isInit)
      {
        if(m_loadFinishedCallBack != null)
        {
          m_loadFinishedCallBack();
        }
    return;
      }

      //
      m_dataPath = path;

        dictExample.Load(m_dataPath,OnLoadFinished);

        dictEquipEquip.Load(m_dataPath,OnLoadFinished);

        dictEquipWeaponType.Load(m_dataPath,OnLoadFinished);

        dictEquipEquipType.Load(m_dataPath,OnLoadFinished);

        dictEquipQulity.Load(m_dataPath,OnLoadFinished);

        dictPlayerProp.Load(m_dataPath,OnLoadFinished);

        dictAbility.Load(m_dataPath,OnLoadFinished);

        dictAbilityProp.Load(m_dataPath,OnLoadFinished);

        dictSystemLanguage.Load(m_dataPath,OnLoadFinished);

        dictSystemStoryTip.Load(m_dataPath,OnLoadFinished);

        dictSystemVersionRecord.Load(m_dataPath,OnLoadFinished);

        dictSystemCheatApp.Load(m_dataPath,OnLoadFinished);

        dictSystemModule.Load(m_dataPath,OnLoadFinished);

        dictSystemQuestion.Load(m_dataPath,OnLoadFinished);

        dictSystemConfig.Load(m_dataPath,OnLoadFinished);

        dictSystemQulity.Load(m_dataPath,OnLoadFinished);

        dictSystemUiAutoLoad.Load(m_dataPath,OnLoadFinished);

        dictSystemRollTip.Load(m_dataPath,OnLoadFinished);

        dictSystemPushMessage.Load(m_dataPath,OnLoadFinished);

        dictSystemGetItemFrom.Load(m_dataPath,OnLoadFinished);

        dictSystemFriendGift.Load(m_dataPath,OnLoadFinished);

        dictSystemAdsGift.Load(m_dataPath,OnLoadFinished);

      //
      DictPreLoadCache.PreLoadCache();
      m_isInit = true;
    }

    //
    private void OnLoadFinished(string filePath)
    {
        m_initCount--;

        if(m_initCount == 0)
        {
            // 表加载完毕
            if(m_loadFinishedCallBack != null)
            {
                m_loadFinishedCallBack();
            }
        }
    }


    public DictExample dictExample = new DictExample();

    public DictEquipEquip dictEquipEquip = new DictEquipEquip();

    public DictEquipWeaponType dictEquipWeaponType = new DictEquipWeaponType();

    public DictEquipEquipType dictEquipEquipType = new DictEquipEquipType();

    public DictEquipQulity dictEquipQulity = new DictEquipQulity();

    public DictPlayerProp dictPlayerProp = new DictPlayerProp();

    public DictAbility dictAbility = new DictAbility();

    public DictAbilityProp dictAbilityProp = new DictAbilityProp();

    public DictSystemLanguage dictSystemLanguage = new DictSystemLanguage();

    public DictSystemStoryTip dictSystemStoryTip = new DictSystemStoryTip();

    public DictSystemVersionRecord dictSystemVersionRecord = new DictSystemVersionRecord();

    public DictSystemCheatApp dictSystemCheatApp = new DictSystemCheatApp();

    public DictSystemModule dictSystemModule = new DictSystemModule();

    public DictSystemQuestion dictSystemQuestion = new DictSystemQuestion();

    public DictSystemConfig dictSystemConfig = new DictSystemConfig();

    public DictSystemQulity dictSystemQulity = new DictSystemQulity();

    public DictSystemUiAutoLoad dictSystemUiAutoLoad = new DictSystemUiAutoLoad();

    public DictSystemRollTip dictSystemRollTip = new DictSystemRollTip();

    public DictSystemPushMessage dictSystemPushMessage = new DictSystemPushMessage();

    public DictSystemGetItemFrom dictSystemGetItemFrom = new DictSystemGetItemFrom();

    public DictSystemFriendGift dictSystemFriendGift = new DictSystemFriendGift();

    public DictSystemAdsGift dictSystemAdsGift = new DictSystemAdsGift();

    //
    public static string[] s_allFileName = new string[]
    {

    "dict_example",

    "dict_equip_equip",

    "dict_equip_weapon_type",

    "dict_equip_equip_type",

    "dict_equip_qulity",

    "dict_player_prop",

    "dict_ability",

    "dict_ability_prop",

    "dict_system_language",

    "dict_system_story_tip",

    "dict_system_version_record",

    "dict_system_cheat_app",

    "dict_system_module",

    "dict_system_question",

    "dict_system_config",

    "dict_system_qulity",

    "dict_system_ui_auto_load",

    "dict_system_roll_tip",

    "dict_system_push_message",

    "dict_system_get_item_from",

    "dict_system_friend_gift",

    "dict_system_ads_gift",

    };
}

