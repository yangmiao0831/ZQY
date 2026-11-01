namespace ZLGCAN;

public struct IProperty
{
	public SetValueFunc SetValue;

	public GetValueFunc GetValue;

	public GetPropertysFunc GetPropertys;
}
