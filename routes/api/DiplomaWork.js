module.exports = [
    {
        method: 'GET',
        path: '/api/diplomawork',
        handler: function ( req, res ) {
            var diplomaworks = req.getDb('simple_cashier').models.DiplomaWork.findAll();
            res( diplomaworks );
        }
    }
]