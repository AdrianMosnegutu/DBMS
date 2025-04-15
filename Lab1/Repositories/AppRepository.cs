using System.Data;
using System.Collections.Generic;

namespace Lab1.Repositories
{
    internal class AppRepository
    {
        private readonly DataSet _dataSet = new DataSet();

        public ParentRepository ParentRepository { get; }
        public ChildRepository ChildRepository { get; }

        public AppRepository(
            string connectionString, 
            string parentTableName, 
            string childTableName,
            string primaryKey, 
            string foreignKey, 
            List<string> columnNames
        )
        {
            this.ParentRepository = new ParentRepository(connectionString, _dataSet, parentTableName);
            this.ChildRepository = new ChildRepository(
                connectionString, 
                _dataSet, 
                childTableName, 
                primaryKey, 
                foreignKey, 
                columnNames
            );
        }
    }
}
