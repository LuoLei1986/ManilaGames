namespace Stocks
{

public  class Cash: Assets
{
    public Cash(int value)
    {
        AssetsType = AssetsType.Cash;
        _value = value;
    }

    private int _value;
    public override int TotalPrice()
    {
        return _value;
    }
}

}
