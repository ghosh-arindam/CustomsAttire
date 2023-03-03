import { Box, useTheme } from "@mui/material";
import { DataGrid, GridToolbar } from "@mui/x-data-grid";
import { tokens } from "../../theme";
// import { mockSupplierData } from "../../data/mockData";
import Header from "../../components/Header";
import React, { useState, useEffect, useMemo } from "react";
import { useDispatch, useSelector } from "react-redux";
import { loadSuppliers } from "../../redux/action";

const SupplierLocal = () => {
  const theme = useTheme();
  const colors = tokens(theme.palette.mode);
  const [pageSize, setPageSize] = useState(5);
  const [rowId, setrowId] = useState([]);
  const { suppliers } = useSelector((state) => state.data);

  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(loadSuppliers());
    // eslint-disable-next-line react-hooks/exhaustive-deps
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
        field: "accountnumber",
        headerName: "Account Number",
        flex: 1,
        cellClassName: "name-column--cell",
      },
      {
        field: "vendorname",
        headerName: "Vendor Name",
        flex: 1,
        cellClassName: "name-column--cell",
      },
      {
        field: "phonenumber",
        headerName: "Phone Number",
        flex: 1,
      },
      {
        field: "address1",
        headerName: "Address1",
        flex: 1,
      },
      {
        field: "address2",
        headerName: "Address 2",
        flex: 1,
      },
      {
        field: "city",
        headerName: "City",
        flex: 1,
      },
      {
        field: "panno",
        headerName: "PAN No",
      },
      {
        field: "gst",
        headerName: "GST",
        flex: 1,
      },
      {
        field: "preferredvendorstatus",
        headerName: "Preferred Vendor",
        flex: 1,
      },
    ],
    // eslint-disable-next-line react-hooks/exhaustive-deps
    [rowId]
  );
  return (
    <div>
      <label>
        <Box>
          <Header title="VENDORS" subtitle="List of Vendors" />

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
              rows={rowSupplierData}
              columns={columns}
              getRowId={(row) => row.id}
              rowsPerPageOptions={[5, 10, 25]}
              pageSize={pageSize}
              onPageSizeChange={(newPageSize) => setPageSize(newPageSize)}
              getRowSpacing={(params) => ({
                top: params.isFirstVisible ? 0 : 5,
                bottom: params.isLastVisible ? 0 : 5,
              })}
              components={{ Toolbar: GridToolbar }}
              onCellEditCommit={(params) => setrowId(params.id)}
            />
          </Box>
        </Box>
      </label>
    </div>
  );
};

export default SupplierLocal;