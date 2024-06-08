const axios = require('axios');
const db = require('arangojs')();

db.useBasicAuth('root', process.env.ARANGO_ROOT_PASSWORD);
collection = db.collection('catFacts');

/* 
Create the collection (we only needed it once)
collection.create().then(
    () => console.log('Collection created'),
    err => console.error('Failed to create collection:', err)
  ); */

axios({
    method:'get',
    url:'https://catfact.ninja/fact'
})
    .then(function(response) {
        collection.save(response.data)
        .then(
            meta => console.log('Cat fact saved: ', meta._rev),
            err => console.error('Failed to save document: ', err)
        );
});
