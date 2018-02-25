
module.exports = function (sequelize, DataTypes) {
    const Sale = sequelize.define('Student', {
        id: {
            type: DataTypes.INTEGER,
            autoIncrement: true,
            primaryKey: true
        },
        username: {
            type: DataTypes.STRING
        },
        passwordHash: {
            type: DataTypes.STRING
        },
        facultyNumber: {
            type: DataTypes.INTEGER
        },
        specialty: {
            type: DataTypes.INTEGER
        },
        faculty: {
            type: DataTypes.INTEGER
        },
        diplomaWork: {
            type: DataTypes.INTEGER
        }
    });
    
    // Class Method
    Sale.associate = function (models) {
    };
    
    // Instance Method
    // Sale.prototype.someMethod = function () {
    // };

    return Sale;
};