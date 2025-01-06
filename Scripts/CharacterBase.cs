using System;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    public string _name;
    public int id;
    public float hpBase, hpRegenBase;
    public float hpPerLvl, hpRegenPerLvl;
    public float manaBase, manaRegenBase;
    public float manaPerLvl, manaRegenPerLvl;
    public float attackBase, attackSpeedBase;
    public float attackPerLvl, attackSpeedPerLvl;
    public float armorBase, armorPerLvl;
    public float magicResistanceBase, magicResistancePerLvl;
    public float movementSpeedBase;
    public float rangeBase;
    public int lvl; 
    private int hpMax, manaMax, hpRegen, manaRegen, ad, attackSpeed,  currentHp, currentMana, ap, armor, magicResistance, movementSpeed, range;

    void Start()
    {
        
    }

    //hpMax
    private int calculateHpMax(float hpBase, float hpPerLvl, float lvl){
        return Mathf.RoundToInt(hpBase + hpPerLvl * (lvl-1));
    }

    public int getHpMax(){
        this.hpMax = calculateHpMax(this.hpBase, this.hpPerLvl, this.lvl);
        return this.hpMax;
    }

    //hpRegen
    private int calculateHpRegen(float hpRegenBase, float hpRegenPerLvl, float lvl){
        return Mathf.RoundToInt(hpRegenBase + hpRegenPerLvl * (lvl-1));
    }

    public int getHpRegen(){
        this.hpRegen = calculateHpRegen(this.hpRegenBase, this.hpRegenPerLvl, this.lvl);
        return this.hpRegen;
    }

    //manaMax
    private int calculateManaMax(float manaBase, float manaPerLvl, float lvl){
        return Mathf.RoundToInt(manaBase + manaPerLvl * (lvl-1));
    }

    public int getManaMax(){
        this.manaMax = calculateManaMax(this.manaBase, this.manaPerLvl, this.lvl);
        return this.manaMax;
    }

    //manaRegen
    private int calculateManaRegen(float manaRegenBase, float manaRegenPerLvl, float lvl){
        return Mathf.RoundToInt(manaRegenBase + manaRegenPerLvl * (lvl-1));
    }

    public int getManaRegen(){
        this.manaRegen = calculateManaRegen(this.manaRegenBase, this.manaRegenPerLvl, this.lvl);
        return this.manaRegen;
    }

    //ap
    private int calculateAP(){
        return 0;
    }

    public int getAP(){
        this.ap = calculateAP();
        return this.ap;
    }

    //ad
    private int calculateAD(float attackBase, float attackPerLvl, float lvl){
        return Mathf.RoundToInt(attackBase + attackPerLvl * (lvl-1));
    }

    public int getAD(){
        this.ad = calculateAD(this.attackBase, this.attackPerLvl, this.lvl);
        return this.ad;
    }

    //attackSpeed
    private int calculateAttackSpeed(float attackSpeedBase, float attackSpeedPerLvl, float lvl){
        return Mathf.RoundToInt(attackSpeedBase * (1 + (attackPerLvl * (lvl-1))));
    }

    public int getAttackSpeed(){
        this.attackSpeed = calculateAttackSpeed(this.attackSpeedBase, this.attackSpeedPerLvl, this.lvl);
        return this.attackSpeed;
    }

    //armor
    private int calculateArmor(float armorBase, float armorPerLvl, float lvl){
        return Mathf.RoundToInt(armorBase + armorPerLvl * (lvl-1));
    }

    public int getArmor(){
        this.armor = calculateArmor(this.armorBase, this.armorPerLvl, this.lvl);
        return this.armor;
    }

    //magicResistance
    private int calculateMagicResistance(float magicResistanceBase, float magicResistancePerLvl, float lvl){
        return Mathf.RoundToInt(magicResistanceBase + magicResistancePerLvl * (lvl-1));
    }

    public int getMagicResistance(){
        this.magicResistance = calculateMagicResistance(this.magicResistanceBase, this.magicResistancePerLvl, this.lvl);
        return this.magicResistance;
    }

    //movementSpeed
    private int calculateMovementSpeed(float movementSpeedBase){
        return Mathf.RoundToInt(movementSpeedBase);
    }

    public int getMovementSpeed(){
        this.movementSpeed = calculateMovementSpeed(this.movementSpeedBase);
        return this.movementSpeed;
    }

    //range
    private int calculateRange(float rangeBase){
        return Mathf.RoundToInt(rangeBase);
    }

    public int getRange(){
        this.range = calculateRange(this.rangeBase);
        return this.range;
    }

    //currentHp
    public void setCurrentHp(int hp){
        this.currentHp = hp;
    }

    public int getCurrentHp(){
        return currentHp;
    }

    //currentMana
    public void setCurrentMana(int mana){
        this.currentMana = mana;
    }

    public int getCurrentMana(){
        return currentMana;
    }
}
