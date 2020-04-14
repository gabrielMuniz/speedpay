import React, { useState } from 'react';
import './App.css';
import ProviderListPage from './pages/ProviderListPage';
import EnterpriseListPage from './pages/EnterpriseListPage';
import { getProviders, getEnterprises } from './services/api';
import { Switch, BrowserRouter as Router, Route } from 'react-router-dom';
import AccessAlarm from '@material-ui/icons/AccessAlarm';
import AirplanemodeActiveTwoTone from '@material-ui/icons/AirplanemodeActiveTwoTone';
import SideBar from './components/SideBar';

const iconStyle = { color: 'white' };

const sidebarItems = [{
  text: "Fornecedores",
  route: "/fornecedores",
  icon: <AccessAlarm style={iconStyle} />
},
{
  text: "Empresas",
  route: "/empresas",
  icon: <AirplanemodeActiveTwoTone style={iconStyle} />
}];

class App extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
      providers: [],
      enterprises: []
    }
  }

  async componentDidMount() {
    const providers = await getProviders();
    this.setState({ providers });

    const enterprises = await getEnterprises();
    this.setState({ enterprises });
  }

  render() {
    const { providers, enterprises } = this.state;

    return (
      <Router>
        <div className="app">
          <div className="side-bar">
            <SideBar items={sidebarItems} />
          </div>
          <main>
            <Switch>
              <Route path="/fornecedores">
                <ProviderListPage rows={providers} />
              </Route>
              <Route path="/empresas">
                <EnterpriseListPage rows={enterprises} />
              </Route>
            </Switch>
          </main>
          <footer>

          </footer>
        </div>
      </Router>
    );
  }
}

export default App;
