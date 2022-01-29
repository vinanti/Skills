function latestdata(){
    const mydata = fetch('http://localhost:3001/articles', 
        {method: 'GET'})
        .then(
            res => res.json()
        )
    return {
        type: '',
        payload: mydata
    }

}