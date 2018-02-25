const path = require( 'path' );
const diplomawork = require('./api/DiplomaWork');

module.exports = () => {
    let register = diplomawork;

    let custom = [ {
        method: 'GET',
        path: '/api',
        handler: function ( req, res ) {
            res( 'hello api' );
        }
    }, {
        method: 'GET',
        path: '/app/{param*}',
        handler: {
            directory: {
                path: 'dist',
                listing: true,
                index: true
            }
        }
    } ];

    return register.concat(custom);
}