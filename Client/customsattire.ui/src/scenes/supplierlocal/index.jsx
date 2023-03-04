import { Box, Button, useTheme } from "@mui/material";
import { DataGrid, gridClasses, GridToolbar } from "@mui/x-data-grid";
import AddIcon from "@mui/icons-material/Add";
import { grey } from "@mui/material/colors";
import { tokens } from "../../theme";
import Header from "../../components/Header";
import React, { useState, useEffect, useMemo } from "react";
//import { useNavigate } from "react-router-dom";
import { useDispatch, useSelector } from "react-redux";
import { loadSuppliers } from "../../redux/action";
//import moment from "moment/moment";

const SupplierLocal = () => {
  const theme = useTheme();
  const colors = tokens(theme.palette.mode);
  const [pageSize, setPageSize] = useState(5);
  const [rowId, setrowId] = useState([]);

  const dispatch = useDispatch();
  const { suppliers } = useSelector((state) => state.data);

  useEffect(() => {
    dispatch(loadSuppliers());
    //eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  const rowSupplierData = suppliers?.map((supplier) => {
    return {
      id: supplier?.id,
      accountNumber: supplier?.accountNumber,
      vendorName: supplier?.vendorName,
      phoneNumber: supplier?.phoneNumber,
      address1: supplier?.address1,
      address2: supplier?.address2,
      city: supplier?.city,
      preferredVendorStatus: supplier?.preferredVendorStatus,
      panNo: supplier?.panNo,
      gst: supplier?.gst,
    };
  });

  const columns = useMemo(
    () => [
      { field: "id", headerName: "ID", flex: 0.5 },
      {
        field: "accountNumber",
        headerName: "Account Number",
        flex: 1,
        cellClassName: "name-column--cell",
        editable: true,
      },
      {
        field: "vendorName",
        headerName: "Vendor Name",
        flex: 1,
        cellClassName: "name-column--cell",
        editable: true,
      },
      {
        field: "phoneNumber",
        headerName: "Phone Number",
        flex: 1,
        editable: true,
      },
      {
        field: "address1",
        headerName: "Address1",
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
        field: "city",
        headerName: "City",
        editable: true,
        flex: 1,
      },
      {
        field: "panNo",
        headerName: "PAN No",
        editable: true,
      },
      {
        field: "gst",
        headerName: "GST",
        flex: 1,
        editable: true,
      },
      {
        field: "preferredVendorStatus",
        headerName: "Preferred Vendor",
        flex: 1,
        editable: true,
      },
      // {
      //   field: "actions",
      //   headerName: "Actions",
      //   type: "actions",
      //   // renderCell: (params) => (
      //   //   <CustomerActions {...{ params, rowId, setrowId }} />
      //   // ),
      // },
    ],
    // eslint-disable-next-line react-hooks/exhaustive-deps
    [rowId]
  );
  return (
    <Box m="20px">
      <Header title="VENDORS" subtitle="List of Vendors" />
      <Button
        variant="outlined"
        color="primary"
        startIcon={<AddIcon />}
        //onClick={() => navigate("/AddCustomer")}
      >
        Add Vendor
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
          rows={rowSupplierData ?? []}
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

export default SupplierLocal;
