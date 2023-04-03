import { Box, Button, useTheme } from "@mui/material";
import { DataGrid, gridClasses, GridToolbar } from "@mui/x-data-grid";
import AddIcon from "@mui/icons-material/Add";
import { grey } from "@mui/material/colors";
import { tokens } from "../../theme";
import Header from "../../components/Header";
import React, { useState, useEffect, useMemo } from "react";
import { useNavigate } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { loadCustomers } from "../../redux/action";
import CustomerActions from "./CustomerActions";
import moment from "moment/moment";

const Customer = () => {
  const theme = useTheme();
  const colors = tokens(theme.palette.mode);
  const [pageSize, setPageSize] = useState(5);
  const [rowId, setrowId] = useState([]);
  const navigate = useNavigate();
  const dispatch = useDispatch();
  const { customers } = useSelector((state) => state.data);

  useEffect(() => {
    dispatch(loadCustomers());
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  const rowDataCustomer = customers?.map((customer) => {
    return {
      id: customer?.id,
      title: customer?.title,
      firstName: customer?.firstName,
      lastName: customer?.lastName,
      phoneNo: customer?.phoneNo,
      emailId: customer?.emailId,
      dob: customer?.dob,
      gender: customer?.gender,
      address1: customer?.address1,
      address2: customer?.address2,
      anniversarydate: customer?.anniversaryDate,
    };
  });

  const columns = useMemo(
    () => [
      { field: "id", headerName: "ID", flex: 0.5 },
      {
        field: "title",
        headerName: "Title",
        flex: 1,
        type: "singleselect",
        valueoptions: ["Mr.", "Mrs.", "Honorable"],
        editable: true,
      },
      {
        field: "firstName",
        headerName: "First Name",
        flex: 1,
        cellClassName: "name-column--cell",
        editable: true,
      },
      {
        field: "lastName",
        headerName: "Last Name",
        flex: 1,
        cellClassName: "name-column--cell",
        editable: true,
      },
      {
        field: "phoneNo",
        headerName: "Phone Number",
        flex: 1,
        editable: true,
      },
      {
        field: "emailId",
        headerName: "Email",
        flex: 1,
        editable: true,
      },
      {
        field: "dob",
        headerName: "DOB",
        type: "date",
        headerAlign: "left",
        align: "left",
        editable: true,
        renderCell: (params) => moment(params.row.dob).format("DD-MM-yyyy"),
      },
      {
        field: "gender",
        headerName: "Gender",
        type: "singleSelect",
        width: 400,
        valueOptions: [
          { value: "", label: "Select One" },
          { value: "M", label: "Male" },
          { value: "F", label: "FeMale" },
          { value: "O", label: "Others" },
        ],
        editable: true,
        flex: 0.1,
      },
      {
        field: "address1",
        headerName: "Address 1",
        flex: 1,
        editable: true,
      },
      {
        field: "address2",
        headerName: "Address 2",
        flex: 1,
        editable: true,
      },
      {
        field: "anniversarydate",
        headerName: "Anniversary Date",
        type: "date",
        headerAlign: "left",
        align: "left",
        editable: true,
        renderCell: (params) =>
          moment(params.row.anniversaryDate).format("DD-MM-yyyy"),
      },
      {
        field: "actions",
        headerName: "Actions",
        type: "actions",
        renderCell: (params) => (
          <CustomerActions {...{ params, rowId, setrowId }} />
        ),
      },
    ],
    [rowId]
  );
  return (
    <Box m="20px">
      <Header title="CUSTOMERS" subtitle="List of Customers" />
      <Button
        variant="outlined"
        color="primary"
        startIcon={<AddIcon />}
        onClick={() => navigate("/AddCustomer")}
      >
        Add Customer
      </Button>
      <Box
        m="40px 0 0 0"
        height="75vh"
        sx={{
          "& .MuiDataGrid-root": {
            border: "none",
          },
          "& .MuiDataGrid-cell": {
            borderBottom: "none",
          },
          "& .name-column--cell": {
            color: colors.greenAccent[300],
          },
          "& .MuiDataGrid-columnHeaders": {
            backgroundColor: colors.blueAccent[700],
            borderBottom: "none",
          },
          "& .MuiDataGrid-virtualScroller": {
            backgroundColor: colors.primary[400],
          },
          "& .MuiDataGrid-footerContainer": {
            borderTop: "none",
            backgroundColor: colors.blueAccent[700],
          },
          "& .MuiCheckbox-root": {
            color: `${colors.greenAccent[200]} !important`,
          },
          "& .MuiDataGrid-toolbarContainer .MuiButton-text": {
            color: `${colors.grey[100]} !important`,
          },
        }}
      >
        <DataGrid
          checkboxSelection
          rows={rowDataCustomer ?? []}
          columns={columns}
          getRowId={(rows) => rows.id}
          rowsPerPageOptions={[5, 10, 25]}
          pageSize={pageSize}
          onPageSizeChange={(newPageSize) => setPageSize(newPageSize)}
          getRowSpacing={(params) => ({
            top: params.isFirstVisible ? 0 : 5,
            bottom: params.isLastVisible ? 0 : 5,
          })}
          sx={{
            [`& .${gridClasses.row}`]: {
              bgcolor: (theme) =>
                theme.palette.mode === "light" ? grey[200] : grey[900],
            },
          }}
          components={{ Toolbar: GridToolbar }}
          onCellEditCommit={(params) => setrowId(params.id)}
        />
      </Box>
    </Box>
  );
};

export default Customer;
