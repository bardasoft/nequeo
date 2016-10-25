/* repositoryRepositorySoap12Proxy.cpp
   Generated by gSOAP 2.8.8 from Repository.h

Copyright(C) 2000-2012, Robert van Engelen, Genivia Inc. All Rights Reserved.
The generated code is released under one of the following licenses:
1) GPL or 2) Genivia's license for commercial use.
This program is released under the GPL with the additional exemption that
compiling, linking, and/or using OpenSSL is allowed.
*/

#include "repositoryRepositorySoap12Proxy.h"

RepositorySoap12Proxy::RepositorySoap12Proxy()
{	RepositorySoap12Proxy_init(SOAP_IO_DEFAULT, SOAP_IO_DEFAULT);
}

RepositorySoap12Proxy::RepositorySoap12Proxy(const struct soap &_soap) : soap(_soap)
{ }

RepositorySoap12Proxy::RepositorySoap12Proxy(const char *url)
{	RepositorySoap12Proxy_init(SOAP_IO_DEFAULT, SOAP_IO_DEFAULT);
	soap_endpoint = url;
}

RepositorySoap12Proxy::RepositorySoap12Proxy(soap_mode iomode)
{	RepositorySoap12Proxy_init(iomode, iomode);
}

RepositorySoap12Proxy::RepositorySoap12Proxy(const char *url, soap_mode iomode)
{	RepositorySoap12Proxy_init(iomode, iomode);
	soap_endpoint = url;
}

RepositorySoap12Proxy::RepositorySoap12Proxy(soap_mode imode, soap_mode omode)
{	RepositorySoap12Proxy_init(imode, omode);
}

RepositorySoap12Proxy::~RepositorySoap12Proxy()
{ }

void RepositorySoap12Proxy::RepositorySoap12Proxy_init(soap_mode imode, soap_mode omode)
{	soap_imode(this, imode);
	soap_omode(this, omode);
	soap_endpoint = NULL;
	static const struct Namespace namespaces[] =
{
	{"SOAP-ENV", "http://schemas.xmlsoap.org/soap/envelope/", "http://www.w3.org/*/soap-envelope", NULL},
	{"SOAP-ENC", "http://schemas.xmlsoap.org/soap/encoding/", "http://www.w3.org/*/soap-encoding", NULL},
	{"xsi", "http://www.w3.org/2001/XMLSchema-instance", "http://www.w3.org/*/XMLSchema-instance", NULL},
	{"xsd", "http://www.w3.org/2001/XMLSchema", "http://www.w3.org/*/XMLSchema", NULL},
	{"mtrep", "http://miktex.org/2006/06/repository", NULL, NULL},
	{"mtrep2", "http://miktex.org/2007/03/repository", NULL, NULL},
	{"mtrep3", "http://miktex.org/2007/07/repository", NULL, NULL},
	{"mtrep4", "http://miktex.org/2007/10/repository", NULL, NULL},
	{"mtrep5", "http://miktex.org/2008/05/repository", NULL, NULL},
	{"ns1", "http://miktex.org/2015/06/repository/RepositorySoap", NULL, NULL},
	{"mtrep6", "http://miktex.org/2015/06/repository", NULL, NULL},
	{"ns2", "http://miktex.org/2015/06/repository/RepositorySoap12", NULL, NULL},
	{NULL, NULL, NULL, NULL}
};
	soap_set_namespaces(this, namespaces);
}

void RepositorySoap12Proxy::destroy()
{	soap_destroy(this);
	soap_end(this);
}

void RepositorySoap12Proxy::reset()
{	destroy();
	soap_done(this);
	soap_init(this);
	RepositorySoap12Proxy_init(SOAP_IO_DEFAULT, SOAP_IO_DEFAULT);
}

void RepositorySoap12Proxy::soap_noheader()
{	this->header = NULL;
}

const SOAP_ENV__Header *RepositorySoap12Proxy::soap_header()
{	return this->header;
}

const SOAP_ENV__Fault *RepositorySoap12Proxy::soap_fault()
{	return this->fault;
}

const char *RepositorySoap12Proxy::soap_fault_string()
{	return *soap_faultstring(this);
}

const char *RepositorySoap12Proxy::soap_fault_detail()
{	return *soap_faultdetail(this);
}

int RepositorySoap12Proxy::soap_close_socket()
{	return soap_closesock(this);
}

int RepositorySoap12Proxy::soap_force_close_socket()
{	return soap_force_closesock(this);
}

void RepositorySoap12Proxy::soap_print_fault(FILE *fd)
{	::soap_print_fault(this, fd);
}

#ifndef WITH_LEAN
#ifndef WITH_COMPAT
void RepositorySoap12Proxy::soap_stream_fault(std::ostream& os)
{	::soap_stream_fault(this, os);
}
#endif

char *RepositorySoap12Proxy::soap_sprint_fault(char *buf, size_t len)
{	return ::soap_sprint_fault(this, buf, len);
}
#endif

int RepositorySoap12Proxy::TryGetRepositoryInfo(const char *endpoint, const char *soap_action, _mtrep__TryGetRepositoryInfo *mtrep__TryGetRepositoryInfo, _mtrep__TryGetRepositoryInfoResponse *mtrep__TryGetRepositoryInfoResponse)
{	struct soap *soap = this;
	struct __ns2__TryGetRepositoryInfo soap_tmp___ns2__TryGetRepositoryInfo;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2006/06/repository/TryGetRepositoryInfo";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__TryGetRepositoryInfo.mtrep__TryGetRepositoryInfo = mtrep__TryGetRepositoryInfo;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__TryGetRepositoryInfo(soap, &soap_tmp___ns2__TryGetRepositoryInfo);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__TryGetRepositoryInfo(soap, &soap_tmp___ns2__TryGetRepositoryInfo, "-ns2:TryGetRepositoryInfo", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__TryGetRepositoryInfo(soap, &soap_tmp___ns2__TryGetRepositoryInfo, "-ns2:TryGetRepositoryInfo", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep__TryGetRepositoryInfoResponse)
		return soap_closesock(soap);
	mtrep__TryGetRepositoryInfoResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep__TryGetRepositoryInfoResponse->soap_get(soap, "mtrep:TryGetRepositoryInfoResponse", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::PickRepository(const char *endpoint, const char *soap_action, _mtrep__PickRepository *mtrep__PickRepository, _mtrep__PickRepositoryResponse *mtrep__PickRepositoryResponse)
{	struct soap *soap = this;
	struct __ns2__PickRepository soap_tmp___ns2__PickRepository;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2006/06/repository/PickRepository";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__PickRepository.mtrep__PickRepository = mtrep__PickRepository;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__PickRepository(soap, &soap_tmp___ns2__PickRepository);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__PickRepository(soap, &soap_tmp___ns2__PickRepository, "-ns2:PickRepository", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__PickRepository(soap, &soap_tmp___ns2__PickRepository, "-ns2:PickRepository", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep__PickRepositoryResponse)
		return soap_closesock(soap);
	mtrep__PickRepositoryResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep__PickRepositoryResponse->soap_get(soap, "mtrep:PickRepositoryResponse", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::GetAllRepositories(const char *endpoint, const char *soap_action, _mtrep__GetAllRepositories *mtrep__GetAllRepositories, _mtrep__GetAllRepositoriesResponse *mtrep__GetAllRepositoriesResponse)
{	struct soap *soap = this;
	struct __ns2__GetAllRepositories soap_tmp___ns2__GetAllRepositories;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2006/06/repository/GetAllRepositories";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__GetAllRepositories.mtrep__GetAllRepositories = mtrep__GetAllRepositories;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__GetAllRepositories(soap, &soap_tmp___ns2__GetAllRepositories);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__GetAllRepositories(soap, &soap_tmp___ns2__GetAllRepositories, "-ns2:GetAllRepositories", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__GetAllRepositories(soap, &soap_tmp___ns2__GetAllRepositories, "-ns2:GetAllRepositories", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep__GetAllRepositoriesResponse)
		return soap_closesock(soap);
	mtrep__GetAllRepositoriesResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep__GetAllRepositoriesResponse->soap_get(soap, "mtrep:GetAllRepositoriesResponse", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::GetRepositories(const char *endpoint, const char *soap_action, _mtrep__GetRepositories *mtrep__GetRepositories, _mtrep__GetRepositoriesResponse *mtrep__GetRepositoriesResponse)
{	struct soap *soap = this;
	struct __ns2__GetRepositories soap_tmp___ns2__GetRepositories;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2006/06/repository/GetRepositories";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__GetRepositories.mtrep__GetRepositories = mtrep__GetRepositories;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__GetRepositories(soap, &soap_tmp___ns2__GetRepositories);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__GetRepositories(soap, &soap_tmp___ns2__GetRepositories, "-ns2:GetRepositories", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__GetRepositories(soap, &soap_tmp___ns2__GetRepositories, "-ns2:GetRepositories", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep__GetRepositoriesResponse)
		return soap_closesock(soap);
	mtrep__GetRepositoriesResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep__GetRepositoriesResponse->soap_get(soap, "mtrep:GetRepositoriesResponse", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::GetListCreationTime(const char *endpoint, const char *soap_action, _mtrep2__GetListCreationTime *mtrep2__GetListCreationTime, _mtrep2__GetListCreationTimeResponse *mtrep2__GetListCreationTimeResponse)
{	struct soap *soap = this;
	struct __ns2__GetListCreationTime soap_tmp___ns2__GetListCreationTime;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2007/03/repository/GetListCreationTime";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__GetListCreationTime.mtrep2__GetListCreationTime = mtrep2__GetListCreationTime;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__GetListCreationTime(soap, &soap_tmp___ns2__GetListCreationTime);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__GetListCreationTime(soap, &soap_tmp___ns2__GetListCreationTime, "-ns2:GetListCreationTime", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__GetListCreationTime(soap, &soap_tmp___ns2__GetListCreationTime, "-ns2:GetListCreationTime", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep2__GetListCreationTimeResponse)
		return soap_closesock(soap);
	mtrep2__GetListCreationTimeResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep2__GetListCreationTimeResponse->soap_get(soap, "mtrep2:GetListCreationTimeResponse", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::GetRepositories2(const char *endpoint, const char *soap_action, _mtrep3__GetRepositories2 *mtrep3__GetRepositories2, _mtrep3__GetRepositories2Response *mtrep3__GetRepositories2Response)
{	struct soap *soap = this;
	struct __ns2__GetRepositories2 soap_tmp___ns2__GetRepositories2;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2007/07/repository/GetRepositories2";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__GetRepositories2.mtrep3__GetRepositories2 = mtrep3__GetRepositories2;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__GetRepositories2(soap, &soap_tmp___ns2__GetRepositories2);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__GetRepositories2(soap, &soap_tmp___ns2__GetRepositories2, "-ns2:GetRepositories2", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__GetRepositories2(soap, &soap_tmp___ns2__GetRepositories2, "-ns2:GetRepositories2", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep3__GetRepositories2Response)
		return soap_closesock(soap);
	mtrep3__GetRepositories2Response->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep3__GetRepositories2Response->soap_get(soap, "mtrep3:GetRepositories2Response", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::PickRepository2(const char *endpoint, const char *soap_action, _mtrep3__PickRepository2 *mtrep3__PickRepository2, _mtrep3__PickRepository2Response *mtrep3__PickRepository2Response)
{	struct soap *soap = this;
	struct __ns2__PickRepository2 soap_tmp___ns2__PickRepository2;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2007/07/repository/PickRepository2";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__PickRepository2.mtrep3__PickRepository2 = mtrep3__PickRepository2;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__PickRepository2(soap, &soap_tmp___ns2__PickRepository2);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__PickRepository2(soap, &soap_tmp___ns2__PickRepository2, "-ns2:PickRepository2", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__PickRepository2(soap, &soap_tmp___ns2__PickRepository2, "-ns2:PickRepository2", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep3__PickRepository2Response)
		return soap_closesock(soap);
	mtrep3__PickRepository2Response->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep3__PickRepository2Response->soap_get(soap, "mtrep3:PickRepository2Response", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::TryGetRepositoryInfo2(const char *endpoint, const char *soap_action, _mtrep3__TryGetRepositoryInfo2 *mtrep3__TryGetRepositoryInfo2, _mtrep3__TryGetRepositoryInfo2Response *mtrep3__TryGetRepositoryInfo2Response)
{	struct soap *soap = this;
	struct __ns2__TryGetRepositoryInfo2 soap_tmp___ns2__TryGetRepositoryInfo2;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2007/07/repository/TryGetRepositoryInfo2";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__TryGetRepositoryInfo2.mtrep3__TryGetRepositoryInfo2 = mtrep3__TryGetRepositoryInfo2;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__TryGetRepositoryInfo2(soap, &soap_tmp___ns2__TryGetRepositoryInfo2);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__TryGetRepositoryInfo2(soap, &soap_tmp___ns2__TryGetRepositoryInfo2, "-ns2:TryGetRepositoryInfo2", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__TryGetRepositoryInfo2(soap, &soap_tmp___ns2__TryGetRepositoryInfo2, "-ns2:TryGetRepositoryInfo2", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep3__TryGetRepositoryInfo2Response)
		return soap_closesock(soap);
	mtrep3__TryGetRepositoryInfo2Response->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep3__TryGetRepositoryInfo2Response->soap_get(soap, "mtrep3:TryGetRepositoryInfo2Response", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::VerifyRepository(const char *endpoint, const char *soap_action, _mtrep4__VerifyRepository *mtrep4__VerifyRepository, _mtrep4__VerifyRepositoryResponse *mtrep4__VerifyRepositoryResponse)
{	struct soap *soap = this;
	struct __ns2__VerifyRepository soap_tmp___ns2__VerifyRepository;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2007/10/repository/VerifyRepository";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__VerifyRepository.mtrep4__VerifyRepository = mtrep4__VerifyRepository;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__VerifyRepository(soap, &soap_tmp___ns2__VerifyRepository);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__VerifyRepository(soap, &soap_tmp___ns2__VerifyRepository, "-ns2:VerifyRepository", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__VerifyRepository(soap, &soap_tmp___ns2__VerifyRepository, "-ns2:VerifyRepository", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep4__VerifyRepositoryResponse)
		return soap_closesock(soap);
	mtrep4__VerifyRepositoryResponse->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep4__VerifyRepositoryResponse->soap_get(soap, "mtrep4:VerifyRepositoryResponse", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::GetRepositories3(const char *endpoint, const char *soap_action, _mtrep5__GetRepositories3 *mtrep5__GetRepositories3, _mtrep5__GetRepositories3Response *mtrep5__GetRepositories3Response)
{	struct soap *soap = this;
	struct __ns2__GetRepositories3 soap_tmp___ns2__GetRepositories3;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2008/05/repository/GetRepositories3";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__GetRepositories3.mtrep5__GetRepositories3 = mtrep5__GetRepositories3;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__GetRepositories3(soap, &soap_tmp___ns2__GetRepositories3);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__GetRepositories3(soap, &soap_tmp___ns2__GetRepositories3, "-ns2:GetRepositories3", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__GetRepositories3(soap, &soap_tmp___ns2__GetRepositories3, "-ns2:GetRepositories3", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep5__GetRepositories3Response)
		return soap_closesock(soap);
	mtrep5__GetRepositories3Response->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep5__GetRepositories3Response->soap_get(soap, "mtrep5:GetRepositories3Response", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::PickRepository3(const char *endpoint, const char *soap_action, _mtrep5__PickRepository3 *mtrep5__PickRepository3, _mtrep5__PickRepository3Response *mtrep5__PickRepository3Response)
{	struct soap *soap = this;
	struct __ns2__PickRepository3 soap_tmp___ns2__PickRepository3;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2008/05/repository/PickRepository3";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__PickRepository3.mtrep5__PickRepository3 = mtrep5__PickRepository3;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__PickRepository3(soap, &soap_tmp___ns2__PickRepository3);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__PickRepository3(soap, &soap_tmp___ns2__PickRepository3, "-ns2:PickRepository3", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__PickRepository3(soap, &soap_tmp___ns2__PickRepository3, "-ns2:PickRepository3", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep5__PickRepository3Response)
		return soap_closesock(soap);
	mtrep5__PickRepository3Response->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep5__PickRepository3Response->soap_get(soap, "mtrep5:PickRepository3Response", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::GetRepositories4(const char *endpoint, const char *soap_action, _mtrep6__GetRepositories4 *mtrep6__GetRepositories4, _mtrep6__GetRepositories4Response *mtrep6__GetRepositories4Response)
{	struct soap *soap = this;
	struct __ns2__GetRepositories4 soap_tmp___ns2__GetRepositories4;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2015/06/repository/GetRepositories4";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__GetRepositories4.mtrep6__GetRepositories4 = mtrep6__GetRepositories4;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__GetRepositories4(soap, &soap_tmp___ns2__GetRepositories4);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__GetRepositories4(soap, &soap_tmp___ns2__GetRepositories4, "-ns2:GetRepositories4", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__GetRepositories4(soap, &soap_tmp___ns2__GetRepositories4, "-ns2:GetRepositories4", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep6__GetRepositories4Response)
		return soap_closesock(soap);
	mtrep6__GetRepositories4Response->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep6__GetRepositories4Response->soap_get(soap, "mtrep6:GetRepositories4Response", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}

int RepositorySoap12Proxy::PickRepository4(const char *endpoint, const char *soap_action, _mtrep6__PickRepository4 *mtrep6__PickRepository4, _mtrep6__PickRepository4Response *mtrep6__PickRepository4Response)
{	struct soap *soap = this;
	struct __ns2__PickRepository4 soap_tmp___ns2__PickRepository4;
	if (endpoint)
		soap_endpoint = endpoint;
	if (!soap_endpoint)
		soap_endpoint = "http://api.miktex.org/Repository.asmx";
	if (!soap_action)
		soap_action = "http://miktex.org/2015/06/repository/PickRepository4";
	soap->encodingStyle = NULL;
	soap_tmp___ns2__PickRepository4.mtrep6__PickRepository4 = mtrep6__PickRepository4;
	soap_begin(soap);
	soap_serializeheader(soap);
	soap_serialize___ns2__PickRepository4(soap, &soap_tmp___ns2__PickRepository4);
	if (soap_begin_count(soap))
		return soap->error;
	if (soap->mode & SOAP_IO_LENGTH)
	{	if (soap_envelope_begin_out(soap)
		 || soap_putheader(soap)
		 || soap_body_begin_out(soap)
		 || soap_put___ns2__PickRepository4(soap, &soap_tmp___ns2__PickRepository4, "-ns2:PickRepository4", NULL)
		 || soap_body_end_out(soap)
		 || soap_envelope_end_out(soap))
			 return soap->error;
	}
	if (soap_end_count(soap))
		return soap->error;
	if (soap_connect(soap, soap_endpoint, soap_action)
	 || soap_envelope_begin_out(soap)
	 || soap_putheader(soap)
	 || soap_body_begin_out(soap)
	 || soap_put___ns2__PickRepository4(soap, &soap_tmp___ns2__PickRepository4, "-ns2:PickRepository4", NULL)
	 || soap_body_end_out(soap)
	 || soap_envelope_end_out(soap)
	 || soap_end_send(soap))
		return soap_closesock(soap);
	if (!mtrep6__PickRepository4Response)
		return soap_closesock(soap);
	mtrep6__PickRepository4Response->soap_default(soap);
	if (soap_begin_recv(soap)
	 || soap_envelope_begin_in(soap)
	 || soap_recv_header(soap)
	 || soap_body_begin_in(soap))
		return soap_closesock(soap);
	mtrep6__PickRepository4Response->soap_get(soap, "mtrep6:PickRepository4Response", "");
	if (soap->error)
		return soap_recv_fault(soap, 0);
	if (soap_body_end_in(soap)
	 || soap_envelope_end_in(soap)
	 || soap_end_recv(soap))
		return soap_closesock(soap);
	return soap_closesock(soap);
}
/* End of client proxy code */
