import React from 'react'

class Myloginidpage extends React.Component {

    render() {
        const { myloginid } = this.props.match.params
        return (
            <div>
                <div className='text-success'>{myloginid}</div>
            </div>
        )
    }
}

export default Myloginidpage
