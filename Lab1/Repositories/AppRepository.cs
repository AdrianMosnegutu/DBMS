using System.Collections.Generic;
using System.Data;

namespace Lab1.Repositories
{
    internal class AppRepository
    {
        private readonly DataSet _dataSet;

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
            _dataSet = new DataSet();

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
