import React from 'react';
import { List, ListItem, Avatar, ListItemText } from '@material-ui/core';
import { Link } from 'react-router-dom';
import FotoUsuarioTemp from '../../../logo.svg';

export const MenuDerecha = ({
    classes,
    usuario,
    salirSesion
}) => (
    <div className={classes.list}>
        <List>
            <ListItem button component={Link}>
                <Avatar src={usuario.foto || FotoUsuarioTemp} />
                <ListItemText classes={{primary: classes.listItemText}} 
                primary={usuario ? usuario.nombreCompleto : ''}></ListItemText>
            </ListItem>
            <ListItem button onClick={salirSesion}>
                <ListItemText classes={{primary: classes.listItemText}} primary='Salir'></ListItemText>
            </ListItem>
        </List>
    </div>
);