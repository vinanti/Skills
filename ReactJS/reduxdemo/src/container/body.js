import React from 'react'
import { connect } from 'react-redux'
import { bindActionCreators } from 'redux'

import { latestdata } from '../action/index' //data from the db.json file
//New data
import Content from '../component/content'
//Old data
//component which is passed inside body.js

class Body extends React.Component {

    componentDidMount() {
        this.props.latestdata()
    }

    render() {
        return (
            <div>
                <Content latestcontent={this.props.articles} />
            </div>
        )
    }

}

//Retieval of Data which may be old or new !!
function mapStateToProps(state) {
    console.log(state)
    return {
        articles: state.articles
    }
}
//Binding the action into the dispatch
function mapDispatchToProps(dispatch) {
    return bindActionCreators({ latestdata }, dispatch)
}

export default connect(mapStateToProps, mapDispatchToProps)(Body)