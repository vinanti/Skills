import React from 'react'

const consoledata = (mydata) => {   //display the data in console.
    console.log(mydata)
}

const Content = (props) => {    //accessing from body
    return (
        <div>
            {consoledata(props)}
        </div>
    )
}

export default Content