import React, { useState } from 'react';
import List from '@material-ui/core/List';
import ListItem from '@material-ui/core/ListItem';
import ListItemText from '@material-ui/core/ListItemText';
import './styles.css';
import { Link } from 'react-router-dom';
import { ListItemIcon } from '@material-ui/core';


const SideBar = props => {

    const [items, setItems] = useState(props.items);

    return (
        <List className="sidebar-items">
            {items.map(item => (
                <Link to={item.route}>
                    <ListItem button key={item.text}>
                        <ListItemIcon>
                            {item.icon}
                        </ListItemIcon>
                        <ListItemText primary={item.text} />
                    </ListItem>
                </Link>
            ))}
        </List>
    )
}

export default SideBar;