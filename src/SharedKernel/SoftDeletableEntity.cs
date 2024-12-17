namespace SharedKernel;

public interface ISoftDeletable
{
    public bool IsDeleted { get; }

    public DateTime? DeletionDate { get; }

    public void SoftDelete();

    public void Restore();
}