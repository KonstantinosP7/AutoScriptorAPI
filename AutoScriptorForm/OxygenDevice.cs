namespace AutoScriptorForm;

public record OxygenDevice
{
    public string Code { get; set; }
    public string State { get; set; }
    public string DateUsedUntil { get; set; }
    public string DateCreated { get; set; }
    public int TimesUsed {  get; set; }
    public string Manufacturer { get; set; }
}