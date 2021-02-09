using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum STATE
{
	STUN,
	BIND,
	BLEED,
	POISON,
	SILENCE,
}
public enum PARAMETER
{
	HP,
	MAP,
	ATK,
	DEF,
	ASP,
	MSP,
}
public class Damage
{
	//대미지 클래스
}
public class State
{
	//상태이상 클래스
}
public class Unit
{
	//유닛 클래스. 단독으로 사용하지 않고 플레이어, 적 유닛 클래스에서 상속해서 쓸 것
	private Dictionary<PARAMETER, int> stats;//스텟
	private List<State> states;//상태이상
	public void InitStat(Dictionary<PARAMETER, int> entry)
	{

    }
	public int GetStat(PARAMETER type)//실적용값을 반환한다.
    {
		return 0;
    }
	public void Dead()//죽는다.
    {

    }
	public void Damaged(Damage dam)//피해를 입는다.
    {

    }
}
