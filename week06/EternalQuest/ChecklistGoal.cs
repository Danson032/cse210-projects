public class ChecklistGoal : Goal
{
    private int _target;
    private int _count;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public override int RecordEvent()
    {
        _count++;
        int total = _points;

        if (_count == _target)
        {
            total += _bonus;
        }

        return total;
    }

    public override bool IsComplete() => _count >= _target;

    public override string GetDisplayString()
    {
        return $"[{(_count >= _target ? "X" : " ")}] {_name} ({_description}) -- Completed {_count}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_count},{_target},{_bonus}";
    }
}