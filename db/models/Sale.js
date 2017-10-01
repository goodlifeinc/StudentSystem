
module.exports = function (sequelize, DataTypes) {
    const Sale = sequelize.define('Sale', {
        id: {
            type: DataTypes.INTEGER,
            autoIncrement: true,
            primaryKey: true
        },
        productId: {
            type: DataTypes.INTEGER
        },
        pcs: {
            type: DataTypes.INTEGER
        },
        totalAmount: {
            type: DataTypes.DECIMAL(10, 2)
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