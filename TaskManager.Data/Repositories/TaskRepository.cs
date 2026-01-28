using Dapper;
using TaskManager.Data.Database;
using TaskManager.Data.Interfaces;
using TaskManager.Domain.Entities;

namespace TaskManager.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly SqliteConnectionFactory _connectionFactory;

        public TaskRepository(SqliteConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IEnumerable<TaskItem> GetAll()
        {
            using var connection = _connectionFactory.CreateConnection();

            const string sql = @"
                        SELECT 
                            Id,
                            Description,
                            User,
                            Status,
                            Priority,
                            DueDate,
                            Notes,
                            IsActive
                        FROM Tasks
                        WHERE IsActive = 1
                        ORDER BY DueDate;";

            return connection.Query<TaskItem>(sql);
        }

        public TaskItem? GetById(int id)
        {
            using var connection = _connectionFactory.CreateConnection();

            const string sql = @"
                SELECT *
                FROM Tasks
                WHERE Id = @Id;";

            return connection.QueryFirstOrDefault<TaskItem>(sql, new { Id = id });
        }

        public void Add(TaskItem task)
        {
            using var connection = _connectionFactory.CreateConnection();

            const string sql = @"
                INSERT INTO Tasks 
                (Description, User, Status, Priority, DueDate, Notes)
                VALUES
                (@Description, @User, @Status, @Priority, @DueDate, @Notes);";

            connection.Execute(sql, task);
        }

        public void Update(TaskItem task)
        {
            using var connection = _connectionFactory.CreateConnection();

            const string sql = @"
                UPDATE Tasks
                SET
                    Description = @Description,
                    User = @User,
                    Status = @Status,
                    Priority = @Priority,
                    DueDate = @DueDate,
                    Notes = @Notes
                WHERE Id = @Id;";

            connection.Execute(sql, task);
        }

        public void Delete(int id)
        {
            using var connection = _connectionFactory.CreateConnection();

            const string sql = @"
                        UPDATE Tasks
                        SET IsActive = 0
                        WHERE Id = @Id; ";

            connection.Execute(sql, new { Id = id });
        }
    }
}
